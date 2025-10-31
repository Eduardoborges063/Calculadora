<!doctype html>
<html lang="pt-BR">
<head>
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width,initial-scale=1" />
  <title>Calculadora Console em C# — Projeto</title>
  <meta name="description" content="Calculadora simples em C# para console — soma, subtração, multiplicação, divisão e histórico de operações." />

  <style>
    :root{
      --bg:#0f1724;
      --card:#0b1220;
      --accent:#7c3aed;
      --muted:#94a3b8;
      --glass: rgba(255,255,255,0.04);
      --glass-2: rgba(255,255,255,0.02);
      --white:#e6eef8;
      font-family: Inter, ui-sans-serif, system-ui, -apple-system, "Segoe UI", Roboto, "Helvetica Neue", Arial;
    }
    *{box-sizing:border-box}
    html,body{height:100%; margin:0; background:linear-gradient(180deg,#071022 0%, #071b2a 60%); color:var(--white); -webkit-font-smoothing:antialiased}
    .wrap{max-width:980px; margin:40px auto; padding:28px; background:linear-gradient(180deg,var(--card), rgba(11,18,32,0.7)); border-radius:14px; box-shadow:0 8px 30px rgba(2,6,23,0.6); border:1px solid rgba(255,255,255,0.03)}
    header{display:flex; gap:18px; align-items:center}
    .logo{width:76px; height:76px; border-radius:12px; display:flex; align-items:center; justify-content:center; background:linear-gradient(135deg,var(--accent), #4f46e5); box-shadow:0 6px 18px rgba(124,58,237,0.18)}
    .logo svg{width:44px; height:44px}
    h1{margin:0; font-size:22px}
    p.lead{margin:6px 0 0; color:var(--muted)}

    .grid{display:grid; grid-template-columns:1fr 340px; gap:22px; margin-top:22px}
    @media (max-width:900px){ .grid{grid-template-columns:1fr; } .right{order:2} }

    .card{background:linear-gradient(180deg,var(--glass), var(--glass-2)); padding:18px; border-radius:12px; border:1px solid rgba(255,255,255,0.03)}
    .section-title{display:flex; align-items:center; gap:10px; color:var(--accent); font-weight:600; margin-bottom:10px}
    ul.features{margin:12px 0 0; padding-left:18px; color:var(--muted)}
    pre {background: rgba(0,0,0,0.22); padding:14px; border-radius:8px; overflow:auto; color:var(--white); margin:12px 0}
    code{font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, "Roboto Mono", monospace; font-size:13px}
    .btns{display:flex; gap:10px; margin-top:12px; flex-wrap:wrap}
    .btn{display:inline-flex; align-items:center; gap:8px; padding:10px 14px; border-radius:10px; text-decoration:none; color:var(--white); font-weight:600; background:linear-gradient(90deg,var(--accent), #4f46e5); box-shadow:0 6px 20px rgba(79,70,229,0.14)}
    .btn.ghost{background:transparent; border:1px solid rgba(255,255,255,0.06); color:var(--white)}
    .meta{font-size:13px; color:var(--muted); margin-top:8px}
    .right .card{position:sticky; top:36px}
    footer{margin-top:22px; color:var(--muted); font-size:13px; display:flex; justify-content:space-between; align-items:center}
    .badge{display:inline-block; padding:6px 10px; border-radius:999px; background:rgba(255,255,255,0.04); color:var(--muted); font-weight:600}
    .screenshot{width:100%; height:180px; border-radius:10px; background:linear-gradient(135deg, rgba(255,255,255,0.02), rgba(255,255,255,0.01)); display:flex; align-items:center; justify-content:center; color:var(--muted); font-size:14px}
    .list {margin:8px 0 0; padding:0; list-style:none}
    .list li{padding:8px 10px; border-radius:8px; background:rgba(255,255,255,0.02); margin-bottom:8px; color:var(--muted)}
  </style>
</head>
<body>
  <div class="wrap" role="main">
    <header>
      <div class="logo" aria-hidden="true">
        <svg viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
          <rect x="3" y="3" width="18" height="18" rx="4" fill="white" opacity="0.12"/>
          <path d="M7 12h10M12 7v10" stroke="white" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
        </svg>
      </div>
      <div>
        <h1>Calculadora Console em C#</h1>
        <p class="lead">Calculadora simples para console com histórico de operações, entrada em forma de expressão e menu interativo.</p>
      </div>
    </header>

    <div class="grid" aria-hidden="false">
      <div>
        <div class="card">
          <div class="section-title">Sobre</div>
          <p class="meta">Projeto criado em C# (Console App). Estrutura modular com classes para tela, operações e histórico. Ideal para estudo e extensão (adicionar funções, UI, salvar em arquivo).</p>

          <div style="margin-top:14px">
            <div class="section-title">Funcionalidades</div>
            <ul class="features">
              <li>Somar, subtrair, multiplicar e dividir</li>
              <li>Entrada como expressão (ex: <code>8*2</code>)</li>
              <li>Histórico de operações durante a execução</li>
              <li>Menu com atalhos inteligentes de saída</li>
            </ul>
          </div>

          <div style="margin-top:14px">
            <div class="section-title">Como executar</div>
            <pre><code>dotnet new console
# Cole o arquivo .cs com o código da calculadora
dotnet run</code></pre>

            <div class="btns">
              <a class="btn" href="#" title="Ver código no GitHub">Ver no GitHub</a>
              <a class="btn ghost" href="#" title="Baixar ZIP">Baixar ZIP</a>
            </div>
          </div>

          <div style="margin-top:14px">
            <div class="section-title">Exemplo rápido</div>
            <pre><code>// No menu, escolha '1 - Fazer cálculo'
Digite a expressão (ex: 5 + 3):
&gt; 10/2
Resultado: 5</code></pre>
          </div>
        </div>

        <div class="card" style="margin-top:16px">
          <div class="section-title">Estrutura do projeto</div>
          <ul class="list">
            <li>Program.cs — entrypoint + menu</li>
            <li>TelaCalculadora.cs — interface e menu</li>
            <li>Operacoes.cs — implementações matemáticas</li>
            <li>Historico.cs — armazenamento do histórico (em memória)</li>
          </ul>
        </div>
      </div>

      <aside class="right">
        <div class="card">
          <div class="section-title">Preview & Screenshots</div>
          <div class="screenshot">Console screenshot placeholder</div>

          <div style="margin-top:12px">
            <div class="section-title">Comandos</div>
            <p class="meta">Opções do menu: <span class="badge">1 - Cálculo</span> <span class="badge">2 - Histórico</span> <span class="badge">3 - Sair</span></p>
          </div>

          <div style="margin-top:12px">
            <div class="section-title">Requisitos</div>
            <p class="meta">.NET SDK 6.0+</p>
          </div>
        </div>

        <div class="card" style="margin-top:12px">
          <div class="section-title">Extras & Roadmap</div>
          <ul class="list">
            <li>Salvar histórico em arquivo (TXT/JSON)</li>
            <li>Suporte a expressões encadeadas (2+ operações com prioridade)</li>
            <li>Versão com interface gráfica (WinForms / WPF)</li>
            <li>Adicionar testes unitários</li>
          </ul>
        </div>
      </aside>
    </div>

    <footer>
      <div>📦 Licença: MIT</div>
      <div>✨ Feito por você — Calculadora Console</div>
    </footer>
  </div>
</body>
</html>
