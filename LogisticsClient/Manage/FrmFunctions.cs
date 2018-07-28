using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using LogisticsClient.AppUtils;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Manage
{
    public partial class FrmFunctions : Form
    {
        private List<UserDto> users;
        private List<FunctionDto> functions;
        private List<FunctionDto> selectedFunctions;
        private Dictionary<string, FunctionNode> nodes;

        private UserDto selectUser;
        public UserDto SelectUser
        {
            get { return selectUser; }
            set
            {
                selectUser = value;
                if (selectUser == null)
                    lblInfo.Text = "";
                else
                {
                    lblInfo.Text = String.Format("{0}的权限", selectUser.UserName);
                }
            }
        }

        public FrmFunctions()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
            trFunctions.CheckBoxes = true;
            selectedFunctions = new List<FunctionDto>();
            nodes = new Dictionary<string, FunctionNode>();
            LoadData();
        }

        private void LoadData()
        {
            trUser.Nodes.Clear();
            nodes.Clear();
            users = WebCall.GetMethod<List<UserDto>>("Users/get", null);
            for (int i = 0;i < users.Count;i++)
            {
                var user = users[i];
                TreeNode tnUser = new TreeNode();
                tnUser.Text = user.UserName;
                tnUser.Tag = i;
                trUser.Nodes.Add(tnUser);
            }

            trFunctions.Nodes.Clear();
            trFunctions.Nodes.Add(new TreeNode("权限"));
            functions = WebCall.GetMethod<List<FunctionDto>>("api/function", null);
            for (int i = 0; i < functions.Count; i++)
            {
                var function = functions[i];
                FunctionNode fn = new FunctionNode(function);
                FunctionNode pNode;
                if (nodes.TryGetValue(fn.function.ParentID.ToString(),out pNode))
                {
                    pNode.Nodes.Add(fn);
                }
                else
                {
                    trFunctions.Nodes[0].Nodes.Add(fn);
                }
                nodes.Add(fn.function.ID.ToString(),fn);
            }
            trFunctions.ExpandAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SelectUser==null)
            {
                return;
            }
            else
            {
                selectedFunctions.Clear();
                foreach (FunctionNode node in trFunctions.Nodes[0].Nodes)
                {
                    CheckFunctionNode(node);
                }

                ModifyFunctionPara para = new ModifyFunctionPara
                {
                    user = users[Convert.ToInt16(trUser.SelectedNode.Tag)],
                    functions = selectedFunctions
                };
                WebResult result =
                    AppUtils.AppUtils.JsonDeserialize<WebResult>(WebCall.PostMethod("api/function", para));
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    MessageBox.Show(LangBase.GetString("MODIFY_SUCCESS"));
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }

        private void CheckFunctionNode(FunctionNode fn)
        {
            if (fn.Checked)
                selectedFunctions.Add(fn.function);
            if (fn.Nodes.Count==0)
            {
                return;
            }
            else
            {
                foreach (FunctionNode node in fn.Nodes)
                {
                    CheckFunctionNode(node);
                }
            }
        }

        private void trUser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取用户当前权限
            SelectUser = users[Convert.ToInt16(trUser.SelectedNode.Tag)];
            List<KeyValuePair<string, string>> paramlist = new List<KeyValuePair<string, string>>();
            paramlist.Add(new KeyValuePair<string, string>("user", SelectUser.UserID.ToString()));
            var functionlist = WebCall.GetMethod<List<String>>("api/function", paramlist);
            foreach (FunctionNode node in trFunctions.Nodes[0].Nodes)
            {
                initFunctions(node, functionlist);
            }
        }

        private void initFunctions(FunctionNode fn,List<String> functionlist)
        {
            fn.Checked = functionlist.IndexOf(fn.function.ID.ToString()) != -1;
            if (fn.Nodes.Count == 0)
            {
                return;
            }
            else
            {
                foreach (FunctionNode node in fn.Nodes)
                {
                    initFunctions(node,functionlist);
                }
            }
        }

    }

    internal class FunctionNode:TreeNode
    {
        public FunctionDto function { get; set; }

        public FunctionNode(FunctionDto function)
        {
            this.function = function;
            this.Text = function.Name;
        }

    }
}
