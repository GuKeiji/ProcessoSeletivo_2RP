﻿using api_processo_seletivo_2rp.Domains;
using api_processo_seletivo_2rp.ViewModels;
using PSRP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_processo_seletivo_2rp.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Tipousuario> ListarTipos();
        Usuario Login(string email, string senha);
        Usuario BuscarUsuario(int idUsuario);
        List<Usuario> ListarTodos();
        void AlterarUsuario(int idUsuario, UsuarioCadastroViewModel novoUsuario);
        void AlterarMeuUsuario(int idUsuario, UsuarioAtualizadoViewModel novoUsuario);
        void ExcluirUsuario(int idUsuario);
        void CadastrarUsuario(UsuarioCadastroViewModel novoUsuario);
        void AlterarSituacao(int idUsuario);
    }
}
