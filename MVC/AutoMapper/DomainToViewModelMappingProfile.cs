﻿using AutoMapper;
using Domain.Entities;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get{ return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            /*var config = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<Cliente, ClienteViewModel>();
                cfg.CreateMap<Produto, ProdutoViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var clienteSource = new Cliente();
            var clienteDest = mapper.Map<Cliente, ClienteViewModel>(clienteSource);


            var produtoSource = new Produto();
            var produtoDest = mapper.Map<Produto, ClienteViewModel>(produtoSource);*/

            //Deprecated, será removido no 5.0
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<Fornecedor, FornecedorViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
            Mapper.CreateMap<Processo, ProcessoViewModel>();
        }
    }
}