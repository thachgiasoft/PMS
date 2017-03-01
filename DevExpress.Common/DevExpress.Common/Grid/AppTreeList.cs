using System;
using DevExpress.XtraTreeList.Nodes;
using System.Windows.Forms;

namespace DevExpress.Common.Grid
{
    public static class AppTreeList
    {
        /// <summary>
        /// Check node con
        /// </summary>
        /// <param name="node"></param>
        /// <param name="check"></param>
        public static void SetCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }
        
        /// <summary>
        /// Check node cha
        /// </summary>
        /// <param name="node"></param>
        /// <param name="check"></param>
        public static void SetCheckedParentNodes(TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }
    }
}
