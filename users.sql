PGDMP                         z            Week3    14.5    14.5     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16415    Week3    DATABASE     d   CREATE DATABASE "Week3" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE "Week3";
                postgres    false            �            1259    32812    users    TABLE     �   CREATE TABLE public.users (
    id bigint NOT NULL,
    email character varying,
    password character varying,
    lastactivity date,
    role character varying
);
    DROP TABLE public.users;
       public         heap    postgres    false            �          0    32812    users 
   TABLE DATA           H   COPY public.users (id, email, password, lastactivity, role) FROM stdin;
    public          postgres    false    211   S       a           2606    32818    users users_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    211            �   �   x�3��M-*KMʯ*)-�vH�M���K���4	,J��5O,�+u��H��H�������4�2�L�,J,I�L��C҆U����H��R���ј��4/�h]j���������z՛r�%��&�#T�f�E�ɩ��ř9)��$�7�P� �<z�     