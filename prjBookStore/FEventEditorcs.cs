using prjBookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prjBookStore
{
    public partial class FEventEditorcs : Form
    {
        private DialogResult _isOk;
        public DialogResult confirm
        {
            get { return _isOk; }
        }
        private tEvent _event;
        public tEvent Event
        { 
            get 
            {   if (_event == null)
                    _event = new tEvent();
                _event.fEventName = CeventName.ColumValue;
                _event.fEventDescription = CEevnetcontent.ColumValue;
                _event.fEventType = CEventType.ColumValue;
                return _event; 
            } 
            set 
            {
                _event = value;
                CeventName.ColumValue = _event.fEventName;
                CEevnetcontent.ColumValue = _event.fEventDescription;
                CEventType.ColumValue = _event.fEventType;
            }
        }
        public FEventEditorcs()
        {
            InitializeComponent();
        }

        private void colum5_Load(object sender, EventArgs e)
        {

        }

        private void FEventEditorcs_Load(object sender, EventArgs e)
        {

        }

        private void StartdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (_event == null)
                _event = new tEvent();
            _event.fStratdate = StartdateTimePicker1.Value;
        }

        private void EnddateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (_event == null)
                _event = new tEvent();
            _event.fEnddate = EnddateTimePicker2.Value;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!isUiValidated())
                return;
            _isOk = DialogResult.OK;
            this.Close();
        }

        private bool isUiValidated()
        {
            string msg = "";
            if (string.IsNullOrEmpty(CeventName.ColumValue))
                msg += "\r\n活動名稱不可空白";
            if (string.IsNullOrEmpty(CEventType.ColumValue))
                msg += "\r\n活動類型不可空白";

            if (!string.IsNullOrEmpty(msg))
                MessageBox.Show(msg);
            return msg == "";
        }

        private void Btncancle_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            this.Close();
        }
    }
}
