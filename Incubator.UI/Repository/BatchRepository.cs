using Incubator.UI.Model;
using Incubator.UI.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Incubator.UI.Repository
{
    public class BatchRepository : IBatchRepository
    {
        public void Add(Batch batch)
        {
            var jsonBatch = JsonConvert.SerializeObject(batch);


            throw new NotImplementedException();
        }

        public void Delete(Batch batch)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Batch> GetAll()
        {
            using (FileStream file = new FileStream(@"C:\Users\LANY\Source\Repos\incubator\Incubator.UI\Repository\Data\Batches.json", FileMode.Open))
            {
                StreamReader reader = new StreamReader(file);
                var jsonStr = reader.ReadToEnd();
                var batches = JsonConvert.DeserializeObject<IEnumerable<Batch>>(jsonStr);
            }

            throw new NotImplementedException();
        }

        public Batch GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Batch GetCurrent()
        {
            var batch = new Batch()
            {
                Name = "Batch 42",
                Program = new Program
                {
                    Name = "Test",
                    Description = "Program for testing incubator",
                    Steps = new List<Step> {
                        new Step {
                            Name = "Setup",
                            Temperature = 37.8,
                            Humidity = 60,
                            Duration = new TimeSpan(21, 0, 0, 0)
                        }
                    }
                },
                Events = new List<Event> {
                    new Event {
                        Description = "Created",
                        Timestamp = DateTime.Now
                    }
                }
            };



            return batch;
        }
    }
}
