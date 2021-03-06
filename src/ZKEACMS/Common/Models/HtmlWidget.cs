/* http://www.zkea.net/ 
 * Copyright 2017 ZKEASOFT 
 * http://www.zkea.net/licenses */

using Easy.MetaData;
using System.ComponentModel.DataAnnotations.Schema;
using ZKEACMS.MetaData;
using ZKEACMS.Widget;

namespace ZKEACMS.Common.Models
{
    [Table("HtmlWidget")]
    public class HtmlWidget : BasicWidget
    {
        public string HTML { get; set; }
    }
    class HtmlWidgetMetaData : WidgetMetaData<HtmlWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.HTML).AsTextArea().AddClass("html").Order(NextOrder());
        }
    }

}
