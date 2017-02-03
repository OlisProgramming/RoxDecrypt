# RoxDecrypt
RoxDecrypt is the easy-to-use toolkit to encrypt, decrypt and break classical ciphers.

# Supported Ciphers
Currently, RoxDecrypt supports:
- Atbash
- ROT13
- Caesar
- Affine

# Cryptanalysis Methods

### Atbash Cipher and ROT13
These hardly need explaining due to the triviality of the ciphers: they don't need keys and thus they can be instantly cracked.

### Caesar and Affine
Because there are only a maximum of 26 Caesar cipher keys and 311 Affine cipher keys, we can simply use a brute-force attempt by attempting decryption with every possible key. Monogram frequencies are used as a scoring mechanism because it is invariant of whether or not the text was reversed. We can subsequently use quadgram frequencies to detect whether it was indeed reversed.
