using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Model;
using System.Linq.Dynamic;

namespace LogisticsClient.Query
{
    internal enum Operators
    {
        More,
        MoreEqual,
        Equal,
        LessEqual,
        Less,
        NotEqual,
        Contain
    }

    public partial class FrmAdvCondition : Form
    {
        public List<ReceiveBill> goods;
        private List<string> operNames = new List<string>() {"大于", "大于等于", "等于", "小于等于", "小于", "不等于", "包含"};

        public FrmAdvCondition(List<ReceiveBill> _goods,DataGridView dg)
        {
            InitializeComponent();
            goods = _goods;
            for (int i = 0;i < dg.ColumnCount;i++)
            {
                DataGridViewColumn dc = dg.Columns[i];
                if (dc.Visible)
                {
                    Condition cd = new Condition(dc);
                    lstField.Items.Add(cd);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstField.SelectedIndex==-1)
            {
                MessageBox.Show(Lang.LangBase.GetString("NOT_SELECT_FIELD"));
                return;
            }

            if (lstOper.SelectedIndex == -1)
            {
                MessageBox.Show(Lang.LangBase.GetString("NOT_SELECT_OPER"));
                return;
            }

            if (txtValue.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(Lang.LangBase.GetString("NOT_INPUT_VALUE"));
                return;
            }

            lstHasSelect.Items.Add(new SelectedCondition((lstField.SelectedItem as Condition).m_dc, convertOperators(lstOper.SelectedItem.ToString()), txtValue.Text));
        }

        private Operators convertOperators(string s)
        {
            Operators[] operators =
            {
                Operators.More,
                Operators.MoreEqual,
                Operators.Equal,
                Operators.LessEqual,
                Operators.Less,
                Operators.NotEqual,
                Operators.Contain
            };
            return operators[operNames.IndexOf(s)];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (SelectedCondition item in lstHasSelect.Items)
            {
                System.Reflection.PropertyInfo propertyInfo = typeof(ReceiveBill).GetProperty(item.field);
                Type fieldType = AppUtils.AppUtils.GetFieldName(propertyInfo.Name);
                try
                {
                    switch (item.oper)
                    {
                        case Operators.More:
                            if (fieldType == typeof(float))
                                goods =
                                    goods.Where(a => (float)propertyInfo.GetValue(a, null) > Convert.ToSingle(item.value))
                                    .ToList();
                            else if (fieldType==typeof(DateTime))
                            {
                                goods =
                                    goods.Where(
                                        a =>
                                            DateTime.Compare(Convert.ToDateTime(propertyInfo.GetValue(a, null)),
                                                Convert.ToDateTime(item.value)) > 0)
                                        .ToList();
                            }
                            break;
                        case Operators.MoreEqual:
                            if (fieldType == typeof(float))
                                goods =
                                    goods.Where(a => (float)propertyInfo.GetValue(a, null) >= Convert.ToSingle(item.value))
                                    .ToList();
                            else if (fieldType==typeof(DateTime))
                            {
                                goods =
                                    goods.Where(
                                        a =>
                                            DateTime.Compare(Convert.ToDateTime(propertyInfo.GetValue(a, null)),
                                                Convert.ToDateTime(item.value)) >= 0)
                                        .ToList();
                            }
                            else
                            {
                                goods =
                                    goods.Where(a => Convert.ToString(propertyInfo.GetValue(a, null)) == Convert.ToString(item.value))
                                    .ToList();
                            }
                            break;
                        case Operators.Equal:
                            if (fieldType == typeof(float))
                                goods =
                                    goods.Where(a => (float)propertyInfo.GetValue(a, null) == Convert.ToSingle(item.value))
                                    .ToList();
                            else if (fieldType == typeof(DateTime))
                            {
                                goods =
                                    goods.Where(
                                        a =>
                                            DateTime.Compare(Convert.ToDateTime(propertyInfo.GetValue(a, null)),
                                                Convert.ToDateTime(item.value)) == 0)
                                        .ToList();
                            }
                            else
                            {
                                goods =
                                    goods.Where(a => Convert.ToString(propertyInfo.GetValue(a, null)) == Convert.ToString(item.value))
                                    .ToList();
                            }
                            break;
                        case Operators.LessEqual:
                            if (fieldType == typeof(float))
                                goods =
                                    goods.Where(a => (float)propertyInfo.GetValue(a, null) <= Convert.ToSingle(item.value))
                                    .ToList();
                            else if (fieldType == typeof(DateTime))
                            {
                                goods =
                                    goods.Where(
                                        a =>
                                            DateTime.Compare(Convert.ToDateTime(propertyInfo.GetValue(a, null)),
                                                Convert.ToDateTime(item.value)) <= 0)
                                        .ToList();
                            }
                            else
                            {
                                goods =
                                    goods.Where(a => Convert.ToString(propertyInfo.GetValue(a, null)) == Convert.ToString(item.value))
                                    .ToList();
                            }
                            break;
                        case Operators.Less:
                            if (fieldType == typeof(float))
                                goods =
                                    goods.Where(a => (float)propertyInfo.GetValue(a, null) < Convert.ToSingle(item.value))
                                    .ToList();
                            else if (fieldType == typeof (DateTime))
                            {
                                goods =
                                    goods.Where(
                                        a =>
                                            DateTime.Compare(Convert.ToDateTime(propertyInfo.GetValue(a, null)),
                                                Convert.ToDateTime(item.value)) < 0)
                                        .ToList();
                            }
                            break;
                        case Operators.NotEqual:
                            if (fieldType == typeof(float))
                                goods =
                                    goods.Where(a => (float)propertyInfo.GetValue(a, null) != Convert.ToSingle(item.value))
                                    .ToList();
                            else if (fieldType==typeof(DateTime))
                            {
                                goods =
                                    goods.Where(
                                        a =>
                                            DateTime.Compare(Convert.ToDateTime(propertyInfo.GetValue(a, null)),
                                                Convert.ToDateTime(item.value)) != 0)
                                        .ToList();
                            }
                            else
                            {
                                goods =
                                    goods.Where(a => Convert.ToString(propertyInfo.GetValue(a, null)) != Convert.ToString(item.value))
                                    .ToList();
                            }
                            break;
                        case Operators.Contain:
                            goods =
                                goods.Where(a => ((string) propertyInfo.GetValue(a, null)).Contains(item.value))
                                    .ToList();
                            break;
                        default:
                            break;
                    }

                }
                catch (Exception)
                {
                }
            }

            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstHasSelect.SelectedIndex!=-1)
            {
                lstHasSelect.Items.RemoveAt(lstHasSelect.SelectedIndex);
            }
        }
    }

    internal class Condition
    {
        public string title { get; set; }
        public string field { get; set; }

        public DataGridViewColumn m_dc { get; set; }

        public Condition(DataGridViewColumn dc)
        {
            title = dc.HeaderText;
            field = dc.DataPropertyName;
            m_dc = dc;
        }

        public override string ToString()
        {
            return title;
        }
    }

    internal class SelectedCondition
    {
        public string title { get; set; }
        public string field { get; set; }

        public Operators oper { get; set; }
        public string value { get; set; }

        public SelectedCondition(DataGridViewColumn dc,Operators _oper,string _value)
        {
            title = dc.HeaderText;
            field = dc.DataPropertyName;
            oper = _oper;
            value = _value;
        }

        public override string ToString()
        {
            List<string> operNames = new List<string>() {"大于", "大于等于", "等于", "小于等于", "小于", "不等于", "包含"};
            return String.Format("【{0}】【{1}】【{2}】", title, operNames[(int) oper], value);
        }
    }
}
