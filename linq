//Group By
var results = from c in repo.GetMany(i => i.ClientID == clientid)
              group c by new
              {
                  c.DistributorName,
                  c.RetailerName,
                  c.RetailerID
              } into gcs
              select new RecceClientListDTO
              {
                  RetailID = gcs.Key.RetailerID,
                  RetailerName = gcs.Key.RetailerName,
                  DistributorName = gcs.Key.DistributorName
              };
