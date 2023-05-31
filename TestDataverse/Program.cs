// See https://aka.ms/new-console-template for more information

using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace connect_to_dataverse_webapi_with_dataverse_client
{
    class Program
    {
        static async Task Main(string[] args)
        {
/*            const string clientId = "4ddd7f27-44cd-4f2c-b5c3-0c4c06cb4892",
                         clientSecret = "9fK8Q~XuKnaVdczVJUWkEAkhy.XvnRUCRoJf2cx0",
                         environment = "orgd418a344.crm5.dynamics.com",
                         username = "ToanBui@Ave173.onmicrosoft.com",
                         password = "supa1@3456";


            var connectionString = @$"Url=https://{environment};AuthType=ClientSecret;ClientId={clientId};ClientSecret={clientSecret}";
            //var connectionString = @$"Url=https://{environment};AuthType=OAuth;Username={username};Password={password}";

            using var serviceClient = new ServiceClient(connectionString);
*/
            /*            var accountsCollection = await serviceClient.RetrieveMultipleAsync(new QueryExpression("toanbui_testtable")
                        {
                            ColumnSet = new ColumnSet("toanbui_multichoice")

                        });

                        Console.WriteLine(string.Join("\n",
                            accountsCollection.Entities
                                .Select(x => $"{x.GetAttributeValue<string>("toanbui_name")}")));*/

            /*            var accountsCollection = await serviceClient.RetrieveMultipleAsync(new QueryExpression("crae4_testtable")
                        {
                            ColumnSet = new ColumnSet(true)

                        });

                        Console.WriteLine(string.Join("\n",
                            accountsCollection.Entities
                                .Select(x => $"{x.GetAttributeValue<string>("crae4_name")}")));*/


            /*            var response = (RetrieveAllEntitiesResponse)serviceClient.Execute(new RetrieveAllEntitiesRequest
                        {
                            EntityFilters = EntityFilters.Entity,
                            RetrieveAsIfPublished = true
                        });

                        // Process the result
                        foreach (var entity in response.EntityMetadata)
                        {
                            // Access the table's metadata
                            var tableName = entity.LogicalName;
                            var tableDisplayName = entity.DisplayName;
                            Console.WriteLine($"{tableName} -- {tableDisplayName}");
                        }*/



/*            var query = new QueryByAttribute("account")
            {
                ColumnSet = new ColumnSet("name")
            };
            query.AddAttributeValue("address1_city", "Redmond");
            EntityCollection accounts = serviceClient.RetrieveMultiple(query);
            var accountReferences = new EntityReferenceCollection();

            accounts.Entities.ToList().ForEach(x => {
                accountReferences.Add(x.ToEntityReference());
            });
*/

            /*            QueryExpression query = new QueryExpression("toanbui_testtable");

                        query.ColumnSet = new ColumnSet("toanbui_name");

                        LinkEntity link = new LinkEntity("toanbui_testtable", "crae4_testtable", "toanbui_testtableid", "toanbui_testuppertablename", JoinOperator.Inner);

                        link.Columns = new ColumnSet("crae4_name");
                        link.EntityAlias = "craeTable";

                        query.LinkEntities.Add(link);

                        EntityCollection results = serviceClient.RetrieveMultiple(query);

                        foreach (var account in results.Entities)
                        {
                            string name = account.GetAttributeValue<string>("toanbui_name");
                            Console.WriteLine(name);

                            if (account.Attributes.Contains("craeTable.crae4_name"))
                            {
                                string firstName = account.GetAttributeValue<AliasedValue>("craeTable.crae4_name").Value.ToString();
                                Console.WriteLine(firstName);
                            }
                        }*/


            /*            // Instantiate a new Entity class instance using the late-bound style
                        var account = new Entity("toanbui_testtable");

                        // Set attribute values
                        account["toanbui_name"] = "Contoso";


                        // Create the entity record
                        Guid accountId = serviceClient.Create(account);
            */

            /*
                        // Set the value of the name column to search for
                        string name = "Contoso";

                        // Create a query expression to retrieve the entity record
                        QueryExpression query = new QueryExpression("toanbui_testtable");
                        query.ColumnSet.AddColumns("toanbui_testtableid");
                        query.Criteria.AddCondition("toanbui_name", ConditionOperator.Equal, name);

                        // Retrieve the entity record
                        EntityCollection results = serviceClient.RetrieveMultiple(query);

                        // Check if an entity record was found
                        if (results.Entities.Count > 0)
                        {
                            // Get the ID of the entity record
                            Guid entityId = results.Entities[0].Id;

                            // Delete the entity record
                            serviceClient.Delete("toanbui_testtable", entityId);
                        }*/


        }
    }
}