using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Enumerators
{
    public static class PaymentStatus
    {
        public const string ST_OK = "OK";
        public const string ST_FAILED = "FAILED";
        public const string ST_APPROVED = "APPROVED";
        public const string ST_APPROVED_PARTIAL = "APPROVED_PARTIAL";
        public const string ST_REJECTED = "REJECTED";
        public const string ST_PENDING = "PENDING";
        public const string ST_PENDING_VALIDATION = "PENDING_VALIDATION";
        public const string ST_REFUNDED = "REFUNDED";
        public const string ST_ERROR = "ERROR";
        public const string ST_UNKNOWN = "UNKNOWN";
    }
}
