using System.Data.SqlClient;
using crud.Models;
using Dapper;

namespace crud.Repository;

    public class AeroportoRepository : IAeroportoRepository
{  
    private readonly IConfiguration configuration;
    private readonly string connectionString;
    public AeroportoRepository(IConfiguration configuration){
        this.configuration = configuration;
        connectionString = this.configuration.GetConnectionString("SqlConnection");
    }

    public async Task<bool> adicionaAeroporto(AeroportoDto request)
    {
     string sql = @"INSERT INTO ClimaAeroporto (Umidade, Visibilidade, CodigoICAO, PressaoAtmosferica, Vento, DirecaoVento, Condicao, CondicaoDesc, Temperatura, AtualizadoEm)
    VALUES (@Umidade, @Visibilidade, @CodigoICAO, @PressaoAtmosferica, @Vento, @DirecaoVento, @Condicao, @CondicaoDesc, @Temperatura, GETDATE())";


     using var con = new SqlConnection(connectionString);
     return await con.ExecuteAsync(sql, request) > 0;
    }
}
