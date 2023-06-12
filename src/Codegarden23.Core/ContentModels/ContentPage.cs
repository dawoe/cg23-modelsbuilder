namespace Codegarden23.Core.ContentModels
{
    public partial class ContentPage
    {
        public string BrowserTitle 
            => string.IsNullOrWhiteSpace(this.PageTitle) 
                ? this.Name : this.PageTitle;
    }
}
