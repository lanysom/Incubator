using Incubator.UI.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incubator.UI.Repository.Interfaces
{
    public interface IBatchRepository : IRepository<Batch>
    {
        Batch GetCurrent();
    }
}
