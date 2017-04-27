using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto.logs
{
    /**
     * @see https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging
     */
    public class LogEventIDs
    {
        public const int ITEM_CREATED = 1000;
        public const int ITEM_LISTED = 4000;
        public const int ITEM_UPDATED = 4001;
        public const int ITEM_NOT_FOUND = 4001;
    }
}
