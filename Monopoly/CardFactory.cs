﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class CardFactory : SquareFactory
    {
        public Type_Card type; // type of card

        public CardFactory(Type_Card type) 
        {
            this.type = type;
        }
        public override Square GetSquare(int position)
        {
            return new Card(type, position);
        }
    }
}
