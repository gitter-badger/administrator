using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Administrator
{
    public static class Notification
    {

        public static void CantEstablishConnection()
        {
            ShowNotificationFrame("����������� ������",
                                  "���������� ���������� ���������� ��� �������� ���� ������. ���������� ����� �������.",
                                  MessageBoxIcon.Stop);
        }

        public static void NeedEnterBlackListReason()
        {
            ShowNotificationFrame("��������",
                                  "���������� ������ ������� ��������� � \"������\" ������.",
                                  MessageBoxIcon.Warning);
        }

        private static void ShowNotificationFrame(string caption, string text, MessageBoxIcon icon)
        {
            XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, icon);
        }
    }
}