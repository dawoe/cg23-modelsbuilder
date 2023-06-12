using Umbraco.Extensions;

namespace Codegarden23.Core.ContentModels
{
    public partial class ContentPage
    {
        public bool HasPageTitle =>
            !string.IsNullOrWhiteSpace(this.PageTitle);

        public string BrowserTitle
            => this.HasPageTitle ? this.PageTitle : this.Name;

        private Home _homePage;

        public Home HomePage
        {
            get
            {
                if (_homePage is null)
                {
                    _homePage = this.AncestorOrSelf<Home>(1);
                }

                return _homePage;
            }
        }
    }
}
