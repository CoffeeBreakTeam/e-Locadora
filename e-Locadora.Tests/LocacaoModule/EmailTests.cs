﻿using e_Locadora.Email;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.LocacaoModule
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void DeveEnviarEmail()
        {
            SMTP email = new SMTP();
            email.enviarEmail("CoffeeBreakAcademia@gmail.com", "teste email projeto locadora", "teste body bla bla.");
        }

        [TestMethod]
        public void DeveEnviarEmailComPDF()
        {
            //SMTP email = new SMTP();
            //email.enviarEmail("CoffeeBreakAcademia@gmail.com", "teste email projeto locadora", "teste body bla bla.");
            Assert.AreEqual(true, false);
        }
    }
}
