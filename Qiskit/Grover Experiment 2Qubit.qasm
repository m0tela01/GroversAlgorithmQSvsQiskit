OPENQASM 2.0;
include "qelib1.inc";

qreg q[5];
creg c[5];

h q[0];
h q[1];
cz q[1],q[0];
h q[0];
h q[1];
x q[0];
x q[1];
cz q[1],q[0];
x q[0];
x q[1];
h q[0];
h q[1];
barrier q[0],q[1],q[2],q[3],q[4];
measure q[0] -> c[0];
measure q[1] -> c[1];