using Autofac;
using JetBrains.Annotations;
using Nethereum.Web3;
using SpecFlow.Autofac;
using VASPSuite.EtherGate.Features.Support.SmartContracts;
using VASPSuite.EtherGate.Features.Support.StepDefinitions;

namespace VASPSuite.EtherGate.Features.Support
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public static class DependencyInjection
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            var builder = new ContainerBuilder();

            builder
                .RegisterType<Accounts>()
                .SingleInstance();
            
            builder
                .RegisterType<SmartContractDeployer>()
                .SingleInstance();
            
            builder
                .RegisterType<Givens>()
                .SingleInstance();
            
            builder
                .RegisterType<Whens>()
                .SingleInstance();

            builder
                .RegisterType<Thens>()
                .SingleInstance();
            
            builder
                .RegisterType<Web3>()
                .As<IWeb3>()
                .SingleInstance();

            
            return builder;
        }
    }
}