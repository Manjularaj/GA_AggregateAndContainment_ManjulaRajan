using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_ManjulaRajan
{
    internal class GraphicsCard
    {

        public enum Brand { Navida, AMD, Intel}


        Brand _graphicsCardBrand;

        public GraphicsCard(Brand graphicsCardBrand)
        {
            _graphicsCardBrand = graphicsCardBrand;
        }
    }
}
