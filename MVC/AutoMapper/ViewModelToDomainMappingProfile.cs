using AutoMapper;
using Domain.Entities;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            /*var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClienteViewModel, Cliente>();
                cfg.CreateMap<ProdutoViewModel, Produto>();
            });

            IMapper mapper = config.CreateMapper();
            var clienteSource = new ClienteViewModel();
            var clienteDest = mapper.Map<ClienteViewModel, Cliente>(clienteSource);


            var produtoSource = new ProdutoViewModel();
            var produtoDest = mapper.Map<ProdutoViewModel, Cliente>(produtoSource);*/

            //Deprecated, será removido no 5.0
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<FornecedorViewModel, Fornecedor>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
            Mapper.CreateMap<ProcessoViewModel, Processo>();
        }
    }
}