using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanialImani1370.Models
{
    public class TableOption
    {
        public string TblContainer { get; set; }
        public string Table { get; set; }
        public string TblTitleHead { get; set; }
        public string TblThead { get; set; }
        public string TblTbody { get; set; }
        public string TblFooter { get; set; }
        public string Th { get; set; }
        public string Tr { get; set; }
        public string SerachAdvance { get; set; }
        public string SerachAdvanceInput { get; set; }
        public string RowNumber { get; set; }
        public string InputSerach { get; set; }
        public string ThDetail { get; set; }
        public string ThEdit { get; set; }
        public string ThDelete { get; set; }
        public string TdDetail { get; set; }
        public string TdEdit { get; set; }
        public string TdDelete { get; set; }
        public string Atag { get; set; }
        public TableOption()
        {
            TblContainer = "tbl-container";
            Table = "table table-striped";
            SerachAdvance = "serach-advance";
            SerachAdvanceInput = "form-control";
            TblTitleHead = "tbl-head";
            TblThead = "tbl-thead";
            TblTbody = "tbl-tbody";
            InputSerach = "form-control txt-box-serach";
            ThDetail = "text-center text-white";
            ThDelete = "text-center text-white";
            ThEdit = "text-center text-white";
            TdDetail = "text-center ";
            TdDelete = "text-center ";
            TdEdit = "text-center t";
            TblFooter = "tbl-footer";
            Atag = "text-white";
            Th = "text-white";
        }
    }
}
