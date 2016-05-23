﻿using System;

namespace UwizardWPF.MVVM
{
    public interface IContainerMapper
    {
        IResolver GetResolver();
        IContainerMapper Register<T>(T instance) where T : class;
        IContainerMapper Register<T, TImpl>() where T : class where TImpl : class, T;
        IContainerMapper RegisterSingle<T, TImpl>() where T : class where TImpl : class, T;
        IContainerMapper Register<T>(Type type) where T : class;
        IContainerMapper Register(Type type, Type impl);
        IContainerMapper Register<T>(Func<IResolver, T> func) where T : class;
    }
}