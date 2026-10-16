using UbsApi.Models;

namespace UbsApi.Services
{
    public class MedicoService
    {
        //GAMBIARRA DO PROF. PARA ADICIONAR OBJETOS A LISTA
        //MedicoModel Medico1 = new()
        //{
        //    Crm = "1",
        //    Nome = "Dra. Ana",
        //    Especialidade = "Clínica geral"
        //};
        //MedicoModel Medico2 = new()
        //{
        //    Crm = "2",
        //    Nome = "Dra. João",
        //    Especialidade = "Cardiologista"
        //};

        private List<MedicoModel> _ListaMedicos = new List<MedicoModel>
        {
            new MedicoModel
            {
                Crm = "2101PE",
                Nome = "Dra. Ana",
                Telefone = "81977742345",
                Especialidade = "Clínica geral"
            },
            new MedicoModel
            {
                Crm = "2304PE",
                Nome = "Dr. João",
                Especialidade = "Cardiologista"
            }
        };

        //validação se o CRM do médico existe

        public bool ValidarMedico(string crm)
        {
            foreach (MedicoModel medico in _ListaMedicos)
            {
                if (medico.Crm == crm)
                {
                    return true;
                }
            }
            return false;
        }

        //Cadastrar médico
        public bool CadastrarMedico(MedicoModel novoMedico)
        {
            if (ValidarMedico(novoMedico.Crm))
            {
                return false;
            }
            _ListaMedicos.Add(novoMedico);
            return true;
        }
        //Editar médico

        //Excluir médico

        //Listar médico
        public List<MedicoModel> ListarMedicos()
        {
            return _ListaMedicos;
        }

        //Buscar médico por CRM
        public MedicoModel BuscarMedico(string crmBuscar)
        {

            foreach (MedicoModel medico in _ListaMedicos)
            {
                if (medico.Crm == crmBuscar)
                {
                    return medico;
                }
            }
            return null;
        }
    }
}