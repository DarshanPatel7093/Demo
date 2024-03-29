﻿//-----------------------------------------------------------------------
// <copyright file="DataModule.cs" company="Dexoc Solutions">
//     Copyright Dexoc Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Demo.Data
{
    using Autofac;
    using Demo.Data.Contract;

    /// <summary>
    /// Contract Class for DataModule.
    /// </summary>
    public class DataModule : Module
    {
        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        protected override void Load(ContainerBuilder builder)
        {            
            builder.RegisterType<V1.CustomerDao>().As<AbstractCustomerDao>().InstancePerDependency();
            builder.RegisterType<V1.SubScriptionDao>().As<AbstractSubScriptionDao>().InstancePerDependency();
            builder.RegisterType<V1.UserDao>().As<AbstractUserDao>().InstancePerDependency();
            builder.RegisterType<V1.StandardDao>().As<AbstractStandardDao>().InstancePerDependency();
            builder.RegisterType<V1.SubjectDao>().As<AbstractSubjectDao>().InstancePerDependency();
            builder.RegisterType<V1.OrderDetailsDao>().As<AbstractOrderDetailsDao>().InstancePerDependency();
            builder.RegisterType<V1.ExamChapterDao>().As<AbstractExamChapterDao>().InstancePerDependency();
            builder.RegisterType<V1.ExamSubjectDao>().As<AbstractExamSubjectDao>().InstancePerDependency();
            builder.RegisterType<V1.ExamDao>().As<AbstractExamDao>().InstancePerDependency();
            builder.RegisterType<V1.ExamVSStandardDao>().As<AbstractExamVSStandardDao>().InstancePerDependency();
            builder.RegisterType<V1.ExamQuestionDao>().As<AbstractExamQuestionDao>().InstancePerDependency();
            builder.RegisterType<V1.ExamStandardDao>().As<AbstractExamStandardDao>().InstancePerDependency();
            base.Load(builder);
        }
    }
}
