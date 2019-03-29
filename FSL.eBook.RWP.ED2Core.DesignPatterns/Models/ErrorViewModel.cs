using System;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}