namespace ATA.Application.Models
{
    public class PageModel<T> where T : class
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public IList<T> Item { get; set; } = default!;
    }
}
