import qsharp

from qsharp import Result
from qsBell.Bell import TestBellState, Grover2Qubit, Grover3Qubit

initials = (Result.One, Result.One)

# for i in initials:
#   res = TestBellState.simulate(count=1000, initial=i)
#   (num_zeros, num_ones, agree) = res
#   print(f'Init:{i: <4} 0s={num_zeros: <4} 1s={num_ones: <4} agree={agree: <3}')


## Grover 2 qubits
for i in initials:
  res = Grover2Qubit.simulate(count=3000, initial=i)
  (num_zeros, num_zeros_q1, num_ones, num_ones_q1, agree, agree1) = res
  print('Init:{i: <4} 0q0s={num_zeros: <4} 0sq1={num_zeros_q1: <4} 1s={num_ones: <4}    1sq1={num_ones_q1: <4}    agree={agree: <3}    agree1={agree1: <3}')

## Grover 3 qubits
# for i in initials:
#   res = Grover3Qubit.simulate(count=1000, initial=i)
#   (num_zeros_q0, num_zeros_q1, num_zeros_q2, num_ones_q0, num_ones_q1, num_ones_q2, agree_q0, agree_q1, agree_q2) = res
#   print(f'Init:{i: <4} 0sq0={num_zeros_q0: <4} 0sq1={num_zeros_q1: <4} 0sq2={num_zeros_q2: <4} 1sq0={num_ones_q0: <4}    1sq1={num_ones_q1: <4}    1sq2={num_ones_q2: <4}    agree0={agree_q0: <4}    agree1={agree_q1: <4}    agree2={agree_q2: <4}')