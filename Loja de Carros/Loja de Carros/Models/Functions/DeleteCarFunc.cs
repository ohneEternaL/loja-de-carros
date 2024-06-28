using Loja_de_Carros.Database;

namespace Loja_de_Carros.Models.Functions;

public class DeleteCarFunc
{
    public void DeleteCar()
    {
        Console.Clear();
        var context = new LojaContext();
        Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine(
                $"                                                                           ╔═════════════════════════════════════════╗");
            Console.WriteLine(
                $"                                                                           ║                                         ║");
            Console.WriteLine(
                $"                                                                           ║             Lista de Carros             ║");
            Console.WriteLine(
                $"                                                                           ║                                         ║");
            Console.WriteLine(
                $"                                                          ╔═════╦══════════╩═╦══════════════════════╦══════╦═════════╩══════════════╗");
            Console.WriteLine(
                $"                                                          ║ ID  ║ Marca      ║ Modelo               ║ Ano  ║ Preço                  ║");
            Console.WriteLine(
                $"                                                          ╠═════╬════════════╬══════════════════════╬══════╬════════════════════════╣");
            
            foreach (var car in context.Veiculos)
            {
                Console.WriteLine(
                    $"                                                          ║ {car.Id,-3} ║ {car.Marca,-10} ║ {car.Modelo,-20} ║ {car.Ano,-2} ║ R${car.Price.ToString("N"),-20} ║");
                Console.WriteLine(
                    $"                                                          ╠═════╬════════════╬══════════════════════╬══════╬════════════════════════╣");
            }

            Console.WriteLine(
                $"                                                          ╚═════╩════════════╩══════════════════════╩══════╩════════════════════════╝");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                                                          > Digite o ID Aqui: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            var veiculo = context.Veiculos.FirstOrDefault(v => v.Id == x);
            context.Veiculos.Remove(veiculo);
            context.SaveChanges();
            
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine(
                $"                                                                              ╔══════════════════════════════════╗");
            Console.WriteLine(
                $"                                                                              ║ Veiculo removido com sucesso!    ║");
            Console.WriteLine(
                $"                                                                              ║ Marca: {veiculo.Marca,-26}║");
            Console.WriteLine(
                $"                                                                              ║ Modelo: {veiculo.Modelo,-25}║");
            Console.WriteLine(
                $"                                                                              ║ Ano: {veiculo.Ano,-28}║");
            Console.WriteLine(
                $"                                                                              ║ Preço: R${veiculo.Price.ToString("N"),-24}║");
            Console.WriteLine(
                $"                                                                              ╚══════════════════════════════════╝");
            
            Thread.Sleep(8000);
            new HomePage().Home();
    }
}