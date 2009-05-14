using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Administrator
{
    public static class Conformation
    {
        public static bool PersonDelation   
        {
            get { return ShowConformationFrame("Подтверждение", "Вы уверены, что хотите удалить этого сотрудника?", MessageBoxButtons.YesNo, MessageBoxIcon.Question,null) == DialogResult.Yes; }
        }

        public static bool ResetConnection
        {
            get {
                return
                    ShowConformationFrame("Ошибка",
                                          "Не удалось насторить подключение к базе данных. Хотите попробовать ещё раз?",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question,null) == DialogResult.OK; }
        }

        public static bool RestoreFromBlackList
        {
            get
            {
                return ShowConformationFrame("Подтверждение",
                                             "Вы уверены что хотите восстановить мз \"чёрного\" списка?",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question,null) == DialogResult.Yes;
            }
        }

        public static bool PersonAdding(string firstName, string surName, IWin32Window owner)
        {
            return ShowConformationFrame("Подтверждение",
                                             string.Format("{0} {1} уже занесён в базу данных. Вы уверены что хотите продолжить?", firstName,surName),
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question,owner) == DialogResult.Yes;
        }

        private static DialogResult ShowConformationFrame(string caption, string text, MessageBoxButtons buttons, MessageBoxIcon icon,IWin32Window owner)
        {
            return XtraMessageBox.Show(owner,text, caption, buttons, icon);
        }
    }
}
