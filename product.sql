PGDMP                         z            Week3    14.5    14.5     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16415    Week3    DATABASE     d   CREATE DATABASE "Week3" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE "Week3";
                postgres    false            �            1259    32785    product    TABLE     J  CREATE TABLE public.product (
    productname character varying NOT NULL,
    productdescription character varying NOT NULL,
    productcolour character varying NOT NULL,
    productbrand character varying NOT NULL,
    productprice bigint NOT NULL,
    categoryid bigint NOT NULL,
    productid bigint NOT NULL,
    id bigint
);
    DROP TABLE public.product;
       public         heap    postgres    false            �          0    32785    product 
   TABLE DATA           �   COPY public.product (productname, productdescription, productcolour, productbrand, productprice, categoryid, productid, id) FROM stdin;
    public          postgres    false    210   P       a           2606    32820    product product_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.product
    ADD CONSTRAINT product_pkey PRIMARY KEY (productid);
 >   ALTER TABLE ONLY public.product DROP CONSTRAINT product_pkey;
       public            postgres    false    210            �   U   x��A
� ���� R�ct7���̔�Oz맃�ia1\]���H0
�����tYH�o��:�P�ݭ7����披s�'*     