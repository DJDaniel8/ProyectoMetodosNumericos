function tabla = Muller(func,x0,x1,x2,porcentaje)
syms x;
format long;
continuar = 1;
tabla = [];
while continuar == 1
    f = str2func(['@(x)',func]);
    fx0 = subs(f, x0);
    fx1 = subs(f, x1);
    fx2 = subs(f, x2); 
    h0 = x1-x0;
    h1 = x2-x1;
    s0 = (fx1-fx0)/(x1-x0);
    s1 = (fx2-fx1)/(x2-x1);
    a = (s1-s0)/(h1+h0);
    b = a*h1+s1;
    c = fx2;
    discriminante = sqrt(b^2- (4*a*c));
    x3 = 0;
    if(discriminante > 0)
        x3 = x2 + ((-2*c)/(b+sqrt(b^2-4*a*c)));
    else
        x3 = x2 + ((-2*c)/(b-sqrt(b^2-4*a*c)));
    end
    Ea = abs((x3-x2)/x3)*100;
    Ea = double(Ea);
    if(Ea < porcentaje)
       continuar = 0; 
    end
    x3 = double(x3);
    tabla = [tabla ; [x0 x1 x2 x3 Ea]]
    x0 = x1; x1 = x2; x2 = x3;
end
fplot(str2func(['@(x)',func]));
grid on;
ax = gca;
ax.XAxisLocation = 'origin';
ax.YAxisLocation = 'origin';
xlim([-10 10]);
ylim([-10 10]);
