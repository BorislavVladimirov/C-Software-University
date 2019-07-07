using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                string s = "";
                if (frm.chkResident.Checked == true)
                    s = "-ДА-";
                else
                    s = "-НЕТ-";
                s = "Резидент: " + s + ", страна рождения: " + frm.cmbCountryBirth.Text.Trim() + ", дата рождения: " + frm.dtpBirth.Value.ToShortDateString() + " г., место рождения: " + frm.txtPlaceBorn.Text.Trim() + (char)13 + (char)10;
                s = s + "тип ДУЛ: " + frm.cmbDUL.Text.Trim() + ", дата выдачи ДУЛ: " + frm.dtpDUL.Value.ToShortDateString() + " г.";
                if (frm.dtpEndDUL.Value.ToShortDateString() != "01.01.1900")
                    s = s + ", дата окончания ДУЛ: " + frm.dtpEndDUL.Value.ToShortDateString() + " г.";
                s = s + (char)13 + (char)10;
                s = s + "Серия и номер ДУЛ: " + frm.txtDUL.Text.Trim() + ", страна выдачи ДУЛ: " + frm.cmbLandDUL.Text.Trim() + ", орган выдачи ДУЛ: " + frm.txtIssue.Text.Trim() + (char)13 + (char)10;

                if (frm.txtDUL2.Text.Trim() != "")
                {
                    s = s + "тип ДУЛ2: " + frm.cmbDUL2.Text.Trim() + ", дата выдачи ДУЛ2:" + frm.dtpDUL2.Value.ToShortDateString() + " г.";
                    if (frm.dtpEndDUL2.Value.ToShortDateString() != "01.01.1900")
                        s = s + ", дата окончания ДУЛ2: " + frm.dtpEndDUL2.Value.ToShortDateString() + " г.";
                    s = s + (char)13 + (char)10;
                    s = s + "Серия и номер ДУЛ2: " + frm.txtDUL2.Text.Trim() + ", страна выдачи ДУЛ2: " + frm.cmbLandDUL2.Text.Trim() + ", орган выдачи ДУЛ2: " + frm.txtIssue2.Text.Trim() + (char)13 + (char)10;
                }

                s = s + "---------------------------------------------------------------" + (char)13 + (char)10;
                s = s + "Адрес:" + (char)13 + (char)10;
                s = s + "Строка 1:" + frm.txtAddress1.Text.Trim() + (char)13 + (char)10;
                s = s + "Строка 2:" + frm.txtAddress2.Text.Trim() + (char)13 + (char)10;
                s = s + "Штат: " + frm.txtState.Text.Trim() + ", нас. пункт: " + frm.txtPunkt.Text.Trim() + ", индекс: " + frm.txtPOSTINDEX.Text.Trim() + ", страна: " + frm.cmbLand.Text.Trim() + (char)13 + (char)10;
                s = s + "Тел. код: " + frm.cmbPhoneCode.Text.Trim() + ", мобильный номер: " + frm.txtPhone.Text.Trim();
            }
    }
}
