﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo01
{
    public class KHomeKlaim : Klaim
    {
        // derived class constructor 
        public KHomeKlaim(int claimid, string desc, double claim_amt, DateTime date_incident, DateTime date_claim, bool isvalid)

            // parent constructor 
            : base(claimid, "KHome", desc, claim_amt, date_incident, date_claim, isvalid) // initialize parent
        {

        }
    }
}
