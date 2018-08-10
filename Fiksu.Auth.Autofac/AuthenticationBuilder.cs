﻿using Autofac;

namespace Fiksu.Auth.Autofac {
    // This class exists purely to allow extensions to build off it(for specific auth handlers etc)
    // it enforces that everything should call AddFiksuAuthentication before adding individual providers
    public class AuthenticationBuilder {
        public ContainerBuilder ContainerBuilder { get; }

        public AuthenticationBuilder(ContainerBuilder builder) {
            ContainerBuilder = builder;
        }
    }
}
