OPENQASM 2.0;
include "qelib1.inc";

qreg q[3];
creg c[3];

h q[0];
h q[1];
h q[2];
barrier q[0],q[1],q[2];//,q[3],q[4];
cx q[1],q[0];
tdg q[0];
cx q[2],q[0];
t q[0];
cx q[1],q[0];
tdg q[0];
cx q[2],q[0];
t q[0];
t q[1];
cx q[2],q[1];
tdg q[1];
cx q[2],q[1];
t q[2];
barrier q[0],q[1],q[2];//,q[3],q[4];
h q[0];
h q[1];
h q[2];
barrier q[0],q[1],q[2];//,q[3],q[4];
x q[0];
x q[1];
x q[2];
barrier q[0],q[1],q[2];//,q[3],q[4];
cx q[1],q[0];
tdg q[0];
cx q[2],q[0];
t q[0];
cx q[1],q[0];
tdg q[0];
cx q[2],q[0];
t q[0];
t q[1];
cx q[2],q[1];
tdg q[1];
cx q[2],q[1];
t q[2];
barrier q[0],q[1],q[2];//,q[3],q[4];
x q[0];
x q[1];
x q[2];
barrier q[0],q[1],q[2];//,q[3],q[4];
h q[0];
h q[1];
h q[2];
barrier q[0],q[1],q[2];//,q[3],q[4];
measure q[0] -> c[0];
measure q[1] -> c[1];
measure q[2] -> c[2];