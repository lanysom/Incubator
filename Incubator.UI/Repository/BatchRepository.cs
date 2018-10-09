using Incubator.UI.Model;
using Incubator.UI.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Incubator.UI.Repository
{
    public class BatchRepository : IBatchRepository
    {
        private IEnumerable<Batch> _data;

        public BatchRepository()
        {
            using (FileStream file = new FileStream(@".\Repository\Data\Batches.json", FileMode.Open))
            {
                StreamReader reader = new StreamReader(file);
                var jsonStr = reader.ReadToEnd();
                _data = JsonConvert.DeserializeObject<IEnumerable<Batch>>(jsonStr);
            }            
        }


        public void Add(Batch batch)
        {
            throw new NotImplementedException();
        }

        public void Delete(Batch batch)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Batch> GetAll()
        {
            return _data;
        }

        public Batch GetById(int id)
        {
            return _data.Where(b => b.Id == id).SingleOrDefault();
        }

        public Batch GetCurrent()
        {
            return _data.Where(b => b.State == BatchState.Running).FirstOrDefault();
        }
    }
}
