namespace AngleSharp.Css.Aggregators
{
    using AngleSharp.Css.Dom;
    using System.Collections.Generic;

    sealed class BorderRadiusAggregator : IValueAggregator
    {
        public ICssValue Collect(IEnumerable<ICssProperty> properties)
        {
            return null;
        }

        public IEnumerable<ICssProperty> Distribute(ICssValue value)
        {
            return null;
        }
    }
}