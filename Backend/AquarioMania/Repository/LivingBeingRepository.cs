using AquarioMania.DataContext;
using Dapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;
using Microsoft.Data.SqlClient;
using AquarioMania.Models.LivingBeing;

namespace AquarioMania.Repository
{
    public class LivingBeingRepository : ILivingBeingRepository
    {
        private readonly DapperContext _context;
        public LivingBeingRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<LivingBeingModel> CreateLivingBeing(LivingBeingModel livingBeing)
        {
            try
            {
                var query = @$"INSERT INTO LivingBeing
                    (name
                    ,scientific_name
                    ,family
                    ,origin
                    ,life_expectancy
                    ,ph
                    ,hardness
                    ,description
                    ,behavior_id
                    ,type_of_water_id
                    ,type_of_life_id
                    ,created_at
                    ,updated_at) OUTPUT INSERTED.* VALUES 
                    ('{livingBeing.Name}'
                    ,'{livingBeing.Scientific_name}'
                    ,'{livingBeing.Family}'
                    ,'{livingBeing.Origin}'
                    ,'{livingBeing.Life_expectancy}'
                    ,'{livingBeing.Ph}'
                    ,'{livingBeing.Hardness}'
                    ,'{livingBeing.Description}'
                    ,'{livingBeing.Behavior_id}'
                    ,'{livingBeing.Type_of_water_id}'
                    ,'{livingBeing.Type_of_life_id}'
                    ,'{livingBeing.Created_at}'
                    ,'{livingBeing.Updated_at}');";


                using(var connection = _context.CreateConnection())
                {
                    var response = await connection.QuerySingleOrDefaultAsync<LivingBeingModel>(query);

                    return response;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Exception while creating livingBeing", ex);
            }
        }

        public async Task<LivingBeingModel> DeleteLivingBeing(int id)
        {
            try
            {
                var query = @$"DELETE FROM LivingBeing OUTPUT DELETED.* WHERE id = '{id}'";

                using(var connection = _context.CreateConnection())
                {
                    var response = await connection.QuerySingleAsync<LivingBeingModel>(query);

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception while deleting livingBeing", ex);
            }
        }

        public async Task<IEnumerable<ListLivingBeingModel>> GetLivingBeing()
        {
            try
            {
                var query = @"SELECT l.*, b.behavior Behavior, t.type_of_life Type_of_life, w.type_of_water Type_of_water
                            FROM LivingBeing l 
                            JOIN Behavior b 
                                    ON b.id = l.behavior_id
                            JOIN TypeOfLife t
                                    ON t.id = l.type_of_life_id
                            JOIN TypeOfWater w 
                                    ON w.id = l.type_of_water_id;";

                using (var connection = _context.CreateConnection()) 
                {
                    var response = await connection.QueryAsync<ListLivingBeingModel>(query);

                    response.Select(x => new ListLivingBeingModel()
                    {
                        Name = x.Name,
                        Scientific_name = x.Scientific_name,
                        Family = x.Family,
                        Origin = x.Origin,
                        Life_expectancy = x.Life_expectancy,
                        Ph = x.Ph,
                        Hardness = x.Hardness,
                        Description = x.Description,
                        Behavior_id = x.Behavior_id,
                        Behavior = x.Behavior,
                        Type_of_water_id = x.Type_of_water_id,
                        Type_of_water = x.Type_of_water,
                        Type_of_life_id = x.Type_of_life_id,
                        Type_of_life = x.Type_of_life,
                        Created_at = x.Created_at,
                        Updated_at = x.Updated_at,
                    }).ToList();

                    return response;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Exception while retieving livingBeing", ex);
            }        
        }

        public async Task<ListLivingBeingModel> GetLivingBeingById(int id)
        {
            try
            {
                var query = @$"SELECT l.*, b.behavior Behavior, t.type_of_life Type_of_life, w.type_of_water Type_of_water
                            FROM LivingBeing l 
                            JOIN Behavior b 
                                    ON b.id = l.behavior_id
                            JOIN TypeOfLife t
                                    ON t.id = l.type_of_life_id
                            JOIN TypeOfWater w 
                                    ON w.id = l.type_of_water_id WHERE l.id = '{id}';";

                using (var connection = _context.CreateConnection())
                {
                    var response = await connection.QuerySingleOrDefaultAsync<ListLivingBeingModel>(query, new {id});

                    response = new ListLivingBeingModel()
                    {
                        Name = response.Name,
                        Scientific_name = response.Scientific_name,
                        Family = response.Family,
                        Origin = response.Origin,
                        Life_expectancy = response.Life_expectancy,
                        Ph = response.Ph,
                        Hardness = response.Hardness,
                        Description = response.Description,
                        Behavior_id = response.Behavior_id,
                        Behavior = response.Behavior,
                        Type_of_water_id = response.Type_of_water_id,
                        Type_of_water = response.Type_of_water,
                        Type_of_life_id = response.Type_of_life_id,
                        Type_of_life = response.Type_of_life,
                        Created_at = response.Created_at,
                        Updated_at = response.Updated_at,
                    };

                    return response;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Exception while retieving livingBeing", ex);
            }
        }

        public async Task<LivingBeingModel> UpdateLivingBeing(LivingBeingModel livingBeing)
        {
            try
            {
                var query = @$"UPDATE LivingBeing SET 
                                name = '{livingBeing.Name}'
                                ,scientific_name = '{livingBeing.Scientific_name}'
                                ,family = '{livingBeing.Family}'
                                ,origin = '{livingBeing.Origin}'
                                ,life_expectancy = '{livingBeing.Life_expectancy}'
                                ,ph = '{livingBeing.Ph}'
                                ,hardness = '{livingBeing.Hardness}'
                                ,description = '{livingBeing.Description}'
                                ,behavior_id = '{livingBeing.Behavior_id}'
                                ,type_of_water_id = '{livingBeing.Type_of_water_id}'
                                ,type_of_life_id = '{livingBeing.Type_of_life_id}'
                                ,updated_at = '{DateTime.Now:yyyy-MM-dd HH:mm:ss}'
                                OUTPUT inserted.*
                                WHERE id = '{livingBeing.Id}'";
                
                using(var connection = _context.CreateConnection())
                {
                    var response = await connection.QuerySingleOrDefaultAsync<LivingBeingModel>(query);

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception while updating livingBeing", ex);

            }
        }
    }
}
