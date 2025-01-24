// Chain of Responsibility

ICompile compiler = new SyntaxAnalyzer()
                        .SetNext(new LexicalAnalyzer()
                        .SetNext(new NewChain()
                        .SetNext(new Linker())));

compiler.Handle();
