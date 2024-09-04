USE lojaConveniencia;

SELECT id_nf, id_item, cod_prod, valor_unit, SUM(valor_unit) AS valor_final FROM produtos;