using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.About;
using LogisticsClient.Lang;
using LogisticsClient.Query;
using Microsoft.Office.Interop.Excel;
using Model;
using Model.Dto;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace LogisticsClient.AppUtils
{
    public class ExcelOper
    {
        public static List<ImportInfo> ImportExcel(String file)
        {
            List<ImportInfo> infos = new List<ImportInfo>();
            Application app = new Application();
            Workbooks wbks = app.Workbooks;
            _Workbook _wbk = wbks.Add(file);
            Sheets shs = _wbk.Sheets;
            Worksheet _wsh = (Worksheet)shs[1];
            int rowCount = 2;
            for (;; rowCount++)
            {
                string _senderName = ((Range) _wsh.Cells[rowCount, 1]).Text.ToString();
                string _senderTel = ((Range)_wsh.Cells[rowCount, 2]).Text.ToString();
                string _receiverName = ((Range)_wsh.Cells[rowCount, 3]).Text.ToString();
                string _receiverTel = ((Range)_wsh.Cells[rowCount, 4]).Text.ToString();
                string _receiverAddress = ((Range)_wsh.Cells[rowCount, 5]).Text.ToString();
                string _tranCompName = ((Range)_wsh.Cells[rowCount, 6]).Text.ToString();
                string _goodsTypeName = ((Range)_wsh.Cells[rowCount, 7]).Text.ToString();
                string _amount = ((Range)_wsh.Cells[rowCount, 8]).Text.ToString();
                string _measure = ((Range)_wsh.Cells[rowCount, 9]).Text.ToString();
                string _unitPrice = ((Range)_wsh.Cells[rowCount, 10]).Text.ToString();
                string _price = ((Range)_wsh.Cells[rowCount, 11]).Text.ToString();
                string _packingtypeName = ((Range)_wsh.Cells[rowCount, 12]).Text.ToString();
                string _paytypeName = ((Range)_wsh.Cells[rowCount, 13]).Text.ToString();
                string _chinaprice = ((Range)_wsh.Cells[rowCount, 14]).Text.ToString();
                string _packingprice = ((Range)_wsh.Cells[rowCount, 15]).Text.ToString();
                string _insurance = ((Range)_wsh.Cells[rowCount, 16]).Text.ToString();
                string _sumprice = ((Range)_wsh.Cells[rowCount, 17]).Text.ToString();
                string _remark = ((Range)_wsh.Cells[rowCount, 18]).Text.ToString();
                string _goodsname = ((Range)_wsh.Cells[rowCount, 19]).Text.ToString();

                if (_senderName == string.Empty)
                    break;

                ImportInfo info = new ImportInfo
                {
                    senderName = _senderName,
                    senderTel = _senderTel,
                    receiverName = _receiverName,
                    receiverTel = _receiverTel,
                    receiverAddress = _receiverAddress,
                    tranCompName = _tranCompName,
                    goodsTypeName = _goodsTypeName,
                    amount = _amount,
                    measure = _measure,
                    unitPrice = _unitPrice,
                    price = _price,
                    packingtypeName = _packingtypeName,
                    paytypeName = _paytypeName,
                    chinaprice = _chinaprice,
                    packingprice = _packingprice,
                    insurance = _insurance,
                    sumprice = _sumprice,
                    remark = _remark,
                    goodsname = _goodsname.Equals(string.Empty) ? _goodsTypeName : _goodsname
                };

                infos.Add(info);
            }

            app.Quit();
            ExcelOper.Kill(app);

            return infos;
        }

        public static List<ImportTrans> ImportTransForExcel(String file)
        {
            List<ImportTrans> infos = new List<ImportTrans>();
            Application app = new Application();
            Workbooks wbks = app.Workbooks;
            _Workbook _wbk = wbks.Add(file);
            Sheets shs = _wbk.Sheets;
            Worksheet _wsh = (Worksheet)shs[1];
            int rowCount = 2;
            for (; ; rowCount++)
            {
                string _billID = ((Range)_wsh.Cells[rowCount, 2]).Text.ToString();
                string _transBillID = string.Empty;
                //13-16列为单号列
                for (int col = 13;col <= 16;col++)
                {
                    string value = ((Range)_wsh.Cells[rowCount, col]).Text.ToString();
                    if (!value.Equals(string.Empty))
                    {
                        _transBillID = value;
                        break;
                    }
                }

                if (_billID.Equals(string.Empty))
                    break;

                ImportTrans info = new ImportTrans 
                {
                    TransOperID = Configure.UserID,
                    BillID = _billID,
                    TransBillID = _transBillID
                };

                infos.Add(info);
            }

            app.Quit();
            ExcelOper.Kill(app);

            return infos;
        }

        public static List<ImportTrans> ImportClearInfos(String file)
        {
            List<ImportTrans> infos = new List<ImportTrans>();
            Application app = new Application();
            Workbooks wbks = app.Workbooks;
            _Workbook _wbk = wbks.Add(file);
            Sheets shs = _wbk.Sheets;
            Worksheet _wsh = (Worksheet)shs[1];
            int rowCount = 2;
            for (; ; rowCount++)
            {
                string _billID = ((Range)_wsh.Cells[rowCount, 2]).Text.ToString();
                string _transBillID = string.Empty;

                if (_billID.Equals(string.Empty))
                    break;

                ImportTrans info = new ImportTrans
                {
                    TransOperID = Configure.UserID,
                    BillID = _billID,
                    TransBillID = _transBillID
                };

                infos.Add(info);
            }

            app.Quit();
            ExcelOper.Kill(app);

            return infos;
        }
        public static void ExportToStock(DataGridView dg)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbooks wbks = app.Workbooks;
            _Workbook _wbk = wbks.Add(System.Reflection.Missing.Value);

            Sheets shs = _wbk.Sheets;
            Worksheet _wsh = (Worksheet)shs[1];

            //创建表头
            string[] titles = {"出货日期","发货单号","货物类型","重量","总件数","包装方式","备注"};
            int remarkCol = 7,amountCol = 5; //备注index + 1
            for (int titleindex = 0; titleindex < titles.Count(); titleindex++)
            {
                _wsh.Cells[1, titleindex + 1] = titles[titleindex];
            }

            //填充数据
            for (int rowIndex = 0; rowIndex < dg.Rows.Count; rowIndex++)
            {
                Range myrange = (Range)_wsh.Cells[rowIndex + 2, 1];
                myrange.NumberFormatLocal = "@";
                myrange.WrapText = true;
                myrange.EntireRow.AutoFit();
                string today = DateTime.Now.ToString("yyyy-MM-dd");
                _wsh.Cells[rowIndex + 2, 1] = today;
                _wsh.Cells[rowIndex + 2, 2] = dg.Rows[rowIndex].Cells["BillID"].Value.ToString();
                _wsh.Cells[rowIndex + 2, 3] = dg.Rows[rowIndex].Cells["GoodsTypeName"].Value.ToString();
                _wsh.Cells[rowIndex + 2, 4] = dg.Rows[rowIndex].Cells["Measure"].Value.ToString();
                _wsh.Cells[rowIndex + 2, 5] = dg.Rows[rowIndex].Cells["Amount"].Value.ToString();
                _wsh.Cells[rowIndex + 2, 6] = dg.Rows[rowIndex].Cells["ColPackingName"].Value.ToString();
            }

            //计算总数及填充备注项
            int sum = 0;
            int i = 2;
            for (; ; i++)
            {
                string temp = "";
                string s = ((Range)_wsh.Cells[i, amountCol]).Text.ToString();
                if (s == "")
                    break;
                int x = Convert.ToInt32(((Range)_wsh.Cells[i, amountCol]).Text.ToString());
                sum += x;
                for (int j = 1; j <= x; j++)
                {
                    temp += x.ToString() + "-" + j.ToString() + ";";
                }

                //自动大小之类的
                Range myrange = (Range)_wsh.Cells[i, remarkCol];
                myrange.NumberFormatLocal = "@";
                myrange.WrapText = true;
                myrange.EntireRow.AutoFit();
                myrange.ColumnWidth = 22;

                string result = temp.Substring(0, temp.Length - 1);
                _wsh.Cells[i, remarkCol] = result;
            }

        

            //求和E
            _wsh.Cells[i, amountCol] = sum;

            //加边框
            Range c1 = _wsh.Cells[1, 1];
            Range c2 = _wsh.Cells[i, remarkCol];
            Range range = (Range)_wsh.get_Range(c1, c2);
            range.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            string filename = DateTime.Now.ToString("yyyyMMdd") + "出货单TLD.xlsx";
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.FileName = filename;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _wbk.SaveAs(sfd.FileName);
            }

            app.Quit();
            Kill(app);//调用kill当前excel进程
        }

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);
        public static void Kill(Microsoft.Office.Interop.Excel.Application excel)
        {
            IntPtr t = new IntPtr(excel.Hwnd);   //得到这个句柄，具体作用是得到这块内存入口 

            int k = 0;
            GetWindowThreadProcessId(t, out k);   //得到本进程唯一标志k
            System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(k);   //得到对进程k的引用
            p.Kill();     //关闭进程k
        }

        internal static void ExportToKM(List<ReceiveBill> bills)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbooks wbks = app.Workbooks;
            _Workbook _wbk = wbks.Add(System.Reflection.Missing.Value);

            Sheets shs = _wbk.Sheets;
            Worksheet _wsh = (Worksheet)shs[1];

            //创建表头
            string[] titles = {"出货日期", "发货单号", "收货人", "联系电话", "收货地址", "货物类型", "重量", "总件数", "包装方式", "转运方式", "备注"};
            for (int titleindex = 0; titleindex < titles.Count(); titleindex++)
            {
                _wsh.Cells[1, titleindex + 1] = titles[titleindex];
            }

            //填充数据
            for (int rowIndex = 0; rowIndex < bills.Count; rowIndex++)
            {
                ReceiveBill dg = bills[rowIndex];
                Range myrange = (Range)_wsh.Cells[rowIndex + 2, 1];
                myrange.NumberFormatLocal = "@";
                myrange.WrapText = true;
                myrange.EntireRow.AutoFit();
                string today = DateTime.Now.ToString("yyyy-MM-dd");
                _wsh.Cells[rowIndex + 2, 1] = today;
                Range billRange = (Range)_wsh.Cells[rowIndex + 2, 2];
                billRange.NumberFormatLocal = "@";
                billRange.WrapText = true;
                billRange.EntireRow.AutoFit();
                _wsh.Cells[rowIndex + 2, 2] = dg.BillID.Substring(7);
                _wsh.Cells[rowIndex + 2, 3] = dg.ReceiverName;
                Range telRange = (Range)_wsh.Cells[rowIndex + 2, 4];
                telRange.NumberFormatLocal = "@";
                telRange.WrapText = true;
                telRange.EntireRow.AutoFit();
                _wsh.Cells[rowIndex + 2, 4] = dg.ReceiverTel;
                _wsh.Cells[rowIndex + 2, 5] = dg.ReceiverAddress;
                _wsh.Cells[rowIndex + 2, 6] = dg.GoodsTypeName;
                _wsh.Cells[rowIndex + 2, 7] = dg.Measure.ToString();
                _wsh.Cells[rowIndex + 2, 8] = dg.Amount;
                _wsh.Cells[rowIndex + 2, 9] = dg.PackingTypeName;
                _wsh.Cells[rowIndex + 2, 10] = dg.TransCompName;
                _wsh.Cells[rowIndex + 2, 11] = dg.Remark;

                for (int tmp = 12;tmp <= 16;tmp++)
                {
                    Range tmpRange = (Range)_wsh.Cells[rowIndex + 2, tmp];
                    tmpRange.NumberFormatLocal = "@";
                    tmpRange.WrapText = true;
                    tmpRange.EntireRow.AutoFit();
                }
            }
            
            string filename = DateTime.Now.ToString("yyyyMMdd") + "转运单TLD.xlsx";
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.FileName = filename;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _wbk.SaveAs(sfd.FileName);
            }

            app.Quit();
            Kill(app);//调用kill当前excel进程
        }

        public static void ExportDG(string _fileName,DataGridView dg)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbooks wbks = app.Workbooks;
            _Workbook _wbk = wbks.Add(System.Reflection.Missing.Value);

            Sheets shs = _wbk.Sheets;
            Worksheet _wsh = (Worksheet)shs[1];

            //创建表头
            for (int titleindex = 0; titleindex < dg.Columns.Count; titleindex++)
            {
                DataGridViewColumn dc = dg.Columns[titleindex];
                if (dc.Visible)
                {
                    Condition cd = new Condition(dc);
                    _wsh.Cells[1, titleindex + 1] = cd.title;
                }
            }

            //填充数据
            for (int rowIndex = 0; rowIndex < dg.Rows.Count; rowIndex++)
            {
                for (int col = 0; col < dg.Columns.Count; col++)
                {
                    DataGridViewColumn dc = dg.Columns[col];
                    if (dc.Visible)
                    {
                        Range myrange = (Range) _wsh.Cells[rowIndex + 2, col + 1];
                        myrange.NumberFormatLocal = "@";
                        myrange.WrapText = true;
                        myrange.EntireRow.AutoFit();
                        _wsh.Cells[rowIndex + 2, col + 1] = dg.Rows[rowIndex].Cells[col].Value == null
                            ? string.Empty
                            : dg.Rows[rowIndex].Cells[col].Value.ToString();
                    }
                }
            }

            _wbk.SaveAs(_fileName);

            app.Quit();
            Kill(app);//调用kill当前excel进
        }

        //导出出库单，从转运单生成出库单
        public static void ExportStockOut()
        {
            int readCol = 5;
            int writeCol = 7;
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() != DialogResult.OK)
                return;

            Application app = new Application();
            Workbooks wbks = app.Workbooks;
            _Workbook _wbk = wbks.Add(op.FileName);

            Sheets shs = _wbk.Sheets;
            Worksheet _wsh = (Worksheet)shs[1];
            DeleteCol(_wsh, 3);
            DeleteCol(_wsh, 3);
            DeleteCol(_wsh, 3);
            DeleteCol(_wsh, 7);

            List<int> deleteRow = new List<int>();
            for (int j = 1; ; j++)
            {
                Range myrange = (Range)_wsh.Cells[j, 1];
                string s = myrange.Text.ToString();
                if (s == "")
                    break;

                //颜色检测Debug代码
                //Range xRange = (Range)_wsh.Cells[j, 2];
                //Console.WriteLine(xRange.Text.ToString() + ":" + xRange.Cells.Font.ColorIndex.ToString());

                if (myrange.Cells.Font.ColorIndex > 1)
                    deleteRow.Add(j);
            }

            for (int count = deleteRow.Count - 1; count >= 0; count--)
            {
                Range delrange = (Range)_wsh.Rows[deleteRow[count]];
                delrange.Delete(XlDeleteShiftDirection.xlShiftUp);
            }



            int sum = 0;
            int i = 2;
            for (; ; i++)
            {
                string temp = "";
                string s = ((Range)_wsh.Cells[i, readCol]).Text.ToString();
                if (s == "")
                    break;
                int x = Convert.ToInt32(((Range)_wsh.Cells[i, readCol]).Text.ToString());
                sum += x;
                for (int j = 1; j <= x; j++)
                {
                    temp += x.ToString() + "-" + j.ToString() + ";";
                }

                //自动大小之类的
                Range myrange = (Range)_wsh.Cells[i, writeCol];
                myrange.NumberFormatLocal = "@";
                myrange.WrapText = true;
                myrange.EntireRow.AutoFit();
                myrange.ColumnWidth = 22;

                string result = temp.Substring(0, temp.Length - 1);
                _wsh.Cells[i, writeCol] = result;
            }


            //求和E
            _wsh.Cells[i, readCol] = sum;

            //加边框
            Range c1 = _wsh.Cells[1, 1];
            Range c2 = _wsh.Cells[i, writeCol];
            Range range = (Range)_wsh.get_Range(c1, c2);
            range.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            string filename = op.FileName.Replace("转运", "出货");
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.FileName = filename;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _wbk.SaveAs(sfd.FileName);
            }

            app.Quit();
            ExcelOper.Kill(app);//调用kill当前excel进程
        }


        private  static bool DeleteCol(Worksheet m_objSheet, int ColNum)
        {
            ((Range)m_objSheet.Cells[1, ColNum]).Select();
            ((Range)m_objSheet.Cells[1, ColNum]).EntireColumn.Delete(0);

            //this.m_objSheet.UsedRange.Columns.Delete(ColNum); 
            return true;
        }

    }
}
