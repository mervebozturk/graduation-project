PGDMP                         z            Week3    14.5    14.5     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16415    Week3    DATABASE     d   CREATE DATABASE "Week3" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE "Week3";
                postgres    false            �            1259    32778    category    TABLE     e   CREATE TABLE public.category (
    categoryid bigint NOT NULL,
    categoryname character varying
);
    DROP TABLE public.category;
       public         heap    postgres    false            �          0    32778    category 
   TABLE DATA           <   COPY public.category (categoryid, categoryname) FROM stdin;
    public          postgres    false    209   -       a           2606    32784    category Category_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.category
    ADD CONSTRAINT "Category_pkey" PRIMARY KEY (categoryid);
 B   ALTER TABLE ONLY public.category DROP CONSTRAINT "Category_pkey";
       public            postgres    false    209            �   @   x�3�.OM,)��,*�2���O-�2�H�+)�2����q��s�sz$�pY��=... L      