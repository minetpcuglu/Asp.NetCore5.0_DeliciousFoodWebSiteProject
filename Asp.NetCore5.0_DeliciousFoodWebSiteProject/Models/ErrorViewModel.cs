using System;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
