﻿using Dislab.Base.DbContexts;
using Dislab.Base.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IAskQuestionRepository _askQuestionRepository;
        private readonly IDapperContext _dapperContext;

        public UnitOfWork(IAskQuestionRepository askQuestionRepository, IDapperContext dapperContext)
        {
            _askQuestionRepository = askQuestionRepository;
            _dapperContext = dapperContext;
        }


        public IAskQuestionRepository AskQuestionRepository => _askQuestionRepository ?? new AskQuestionRepository(_dapperContext);
    }
}