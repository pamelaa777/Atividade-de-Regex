# Atividade-de-Regex

1) Crie uma aplicação de console em C# que solicite ao usuário a digitação de uma senha. O programa deve verificar se a senha inserida é considerada "forte" de acordo com as seguintes regras:
A senha deve ter entre 7 e 16 caracteres.
Deve conter pelo menos uma letra minúscula (a-z).
Deve conter pelo menos uma letra maiúscula (A-Z).
Deve conter pelo menos um dígito (0-9).
Deve conter pelo menos um caractere especial entre os seguintes:
! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .
Se a senha for forte, o programa exibe uma mensagem de sucesso e termina. Caso contrário, deve informar ao usuário que a senha não é forte e pedir para digitar novamente, repetindo esse processo até que uma senha forte seja fornecida.

Use a regex @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()+=_\-{}\[\]:;""'?<>,.]).{7,16}$" e explique o que cada parte faz.

2) Considere o arquivo JSON com os Prêmios Nobel, encontre o primeiro nome (firstname) dos ganhadores do prêmio de economia ("category": "economics")
