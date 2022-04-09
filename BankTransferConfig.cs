using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_1302204061
{

    class TransferConfig
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }

        public TransferConfig() { }
        public TransferConfig(int threshold, int low_fee, int high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;

        }
    }

    class BiayaTransferConfig
    {
        public TransferConfig transfer;
        public const String filepath = @"TransferConfig.json";
        public BiayaTransferConfig() { }
    }

}
