namespace AngleSharp.Css.Aggregators
{
    using AngleSharp.Css.Dom;
    using System.Collections.Generic;

    sealed class BorderStyleAggregator : IValueAggregator
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