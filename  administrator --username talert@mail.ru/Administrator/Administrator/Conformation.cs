using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Administrator
{
    public static class Conformation
    {
        public static bool PersonDelation   
        {
            get { return ShowConformationFrame("Подтверждение", "Вы уверены, что хотите удалить этого сотрудника?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK; }
        }

        public static bool ResetConnection
        {
            get {
                return
                    ShowConformationFrame("Ошибка",
                                          "Не удалось насторить подключение к базе данных. Хотите попробовать ещё раз?",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK; }
        }

        private static DialogResult ShowConformationFrame(string caption, string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return XtraMessageBox.Show(text, caption, buttons, icon);
        }
    }

    public static class Notification
    {

        public static void CantEstablishConnection()
        {
            ShowNotificationFrame("Критическая ошибка",
                                  "Невозможно установить соединение или обновить базу данных. Приложение будет закрыто.",
                                  MessageBoxIcon.Stop);
        }

        public static void NeedEnterBlackListReason()
        {
            ShowNotificationFrame("Внимание",
                                  "Необходимо ввести причину занесения в \"чёрный\" список.",
                                  MessageBoxIcon.Warning);
        }

        private static void ShowNotificationFrame(string caption, string text, MessageBoxIcon icon)
        {
            XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, icon);
        }
    }
}
