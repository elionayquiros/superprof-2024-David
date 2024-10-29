using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.Interfaces.Inventario.Crear
{
    public interface ICrearRepuestoLN
    {
        Task<int> Guardar(RepuestoDto elRepuesto);
    }
}
