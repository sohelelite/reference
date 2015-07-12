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
====================================================================================================================
//Get Result by ID list 
List<int> productIDList = repo.GetMany(i => i.CategoryID == id).Select(n => Convert.ToInt32(n.ProductID)).ToList();
return GetProductByIDList(productIDList);
public IEnumerable<ViewProduct> GetProductByIDList(List<int> ids)
        {
            using (var uow = new DMCCUnitOfWork())
            {
                var repo = new GenericRepository<ViewProduct>();
                repo.UnitOfWork = uow;
                return repo.GetMany(i => ids.Contains(i.ProductID) && i.Active == "Y");
            }
        }
====================================================================================================================        
//From Date - To Date
var now = DateTime.Now.Date;
var adv = repo.GetMany(i => i.Active == "Y" && now >= i.FromDate && now <= i.ToDate).OrderBy(o => o.Index);
====================================================================================================================        
