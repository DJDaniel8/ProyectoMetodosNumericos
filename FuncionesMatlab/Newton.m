function raiz = Newton(func,nIteraciones,nInicial)
syms x;
format long;
f = str2func(['@(x)',func]);
fp = diff(f,x,1);
xn = nInicial;
raiz = [nInicial+0.00];
for i = 1:1:nIteraciones
    xn = xn-(subs(f,xn)/subs(fp,xn));
    disp(num2str(double(xn)));
    xn = double(xn);
    raiz = [raiz xn];
end
fplot(str2func(['@(x)',func]));
grid on;
ax = gca;
ax.XAxisLocation = 'origin';
ax.YAxisLocation = 'origin';
xlim([-10 10]);
ylim([-10 10]);
