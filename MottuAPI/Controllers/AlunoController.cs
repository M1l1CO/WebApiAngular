using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MottuAPI.Models;

namespace MottuAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly ApplicationDbContext _contexto;

        public AlunoController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> GetAll(){
            return await _contexto.Alunos.ToListAsync();
           
        }

        [HttpGet("{alunoId}")]
        public async Task<ActionResult<Aluno>> GetAlunoIdAsync(int AlunoID){
            Aluno aluno = await _contexto.Alunos.FindAsync(AlunoID);

            if(aluno == null)
                return NotFound ();
            
            return aluno;
        }

        [HttpPost]
        public async Task<ActionResult<Aluno>> SalvarAlunoAsync(Aluno aluno){
            await _contexto.Alunos.AddAsync(aluno);
            await _contexto.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> AtualizaAlunoAsync(Aluno aluno){
            _contexto.Alunos.Update(aluno);
            await _contexto.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{alunoId}")]

        public async Task<ActionResult> ExcluirAlunoAsync(int AlunoID){
            Aluno aluno = await _contexto.Alunos.FindAsync(AlunoID);
            _contexto.Remove(aluno);
            await _contexto.SaveChangesAsync();
            return Ok();
        }


    }
}