Xades.NetCore
=============

 
INTRODUZIONE
-------------
FirmaXadesNet è una libreria scritta in C# per .NET 5.0  per la creazione di firme XAdES. È stata realizzata dal Dipartimento delle Nuove Tecnologie del Dipartimento di Urbanistica del Comune Spagnolo di Cartagena (Murcia). Si basa su una modifica dello starter kit XAdES sviluppato da Microsoft France.


CARATTERISTICHE
---------------

- Creazione di firme of XAdES-BES, XAdES-EPES, XAdES-T y XAdES-XL.

- Utilizzo di tutti i tipi di certificati supportati da Windows, anche su Smart Card, Token Usb, CNS

- Formati Supportati: Externally Detached, Internally Detached, Enveloped,Enveloping.

- Validazione dei Certificati tramite Authority OCSP o liste di revoca.

- Supporto di cofirmatari e controfirmatari.

- Supporto di RSA-SHA1, RSA-SHA256 y RSA-SHA512.

All'interno della soluzione è presente un progetto con esempi di utilizzo della libreria. Alcuni degli esempi fanno uso del timestamp server  ACCV (Agencia de Tecnología y Certificación Electrónica, Spagna). 

Come esempio di uitlizzo avviare il progetto TextFirmaXades, che consente di firmare digitalmente i file Xml.
