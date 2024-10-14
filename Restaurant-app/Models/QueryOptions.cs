using System.Linq.Expressions;

namespace Restaurant_app.Models
{
    public class QueryOptions<T> where T : class
    {
        public Expression<Func<T, Object>> OrderBy { get; set; } = null!;
        public Expression<Func<T, bool>> Where { get; set; } = null!;

        private string[] includes = Array.Empty<string>();

        public string Includes
        {
            set => includes = value.Replace(" ", "").Split(',');
        }

        public string[] GetIncludes() => includes;
        //public string[] GetIncludes()
        //{
        //    return includes;
        //}

        public bool HasWhere => Where != null;
        public bool HasOrderBy => OrderBy != null;
        //public bool HasOrderBy
        //{
        //    get
        //    {
        //        return OrderBy != null;
        //    }
        //}
        
    }
}