﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibrary
{
    interface CardActions
    {
        bool PlaceCard();
        bool PickUpCard();
        bool SellCard();
        bool BuyCard();
       
    }
}
