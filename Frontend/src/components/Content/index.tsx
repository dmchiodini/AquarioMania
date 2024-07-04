import {
  Container,
  BoxContent,
  RecentPostContainer,
  ImageRecentPost,
  ContentRecentePost,
  TitleRecentPost,
  ImageRecentPostContainer,
  DateRecentPost,
  BoxRecentPostContent,
  ListItemContainer,
  Item,
  UserImageContainer,
  UserImage,
  PostContentContainer,
  TitlePost,
  PostInfoContainer,
  TitleSession,
} from './styles';

import danio from '../../assets/images/danio.jpg';
import userImage from '../../assets/images/userimage.png';

const Content = () => {
  return (
    <Container>
      <BoxContent>
        <TitleSession>DESTAQUE</TitleSession>
        <RecentPostContainer>
          <ImageRecentPostContainer>
            <ImageRecentPost src={danio} />
          </ImageRecentPostContainer>
          <BoxRecentPostContent>
            <ContentRecentePost>
              <TitleRecentPost>
                <h1>Danio Rosa (Danio roseus)</h1>
                <h2>(Fang & Kottelat, 2000)</h2>
              </TitleRecentPost>
              <span>
                É uma espécie relativamente nova no aquarismo, mas se mostra
                bastante popular, principalmente no exterior, devido seu baixo
                valor e resistência. Por vezes é vendido como ‘purple passion
                danio’. É muito semelhante a B. albolineata, mas difere pelo
                corpo relativamente mais magro, barbos rostrais mais curtos e
                falta de faixas escuras na metade posterior do corpo. danio’. É
                muito semelhante a B. albolineata, mas difere pelo corpo
                relativamente mais magro, barbos rostrais mais curtos e falta de
                faixas escuras na metade posterior do corpo. danio’. É muito
                semelhante a B.
              </span>
            </ContentRecentePost>
            <DateRecentPost>
              <span>Data Postagem:</span>
              <span>26/06/2024</span>
            </DateRecentPost>
          </BoxRecentPostContent>
        </RecentPostContainer>
      </BoxContent>

      <BoxContent>
        <TitleSession>Ultímas em Fórum</TitleSession>
        <ListItemContainer>
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={userImage} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={userImage} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>{' '}
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={userImage} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={userImage} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={userImage} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
        </ListItemContainer>
      </BoxContent>

      <BoxContent>
        <TitleSession>Últimas em Animais</TitleSession>
        <ListItemContainer>
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={danio} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={danio} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>{' '}
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={danio} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={danio} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
          <Item>
            <UserImageContainer>
              <UserImage alt="" src={danio} />
            </UserImageContainer>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
        </ListItemContainer>
      </BoxContent>

      <BoxContent>
        <TitleSession>Últimas em Artigos</TitleSession>
        <ListItemContainer>
          <Item>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
          <Item>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>{' '}
          <Item>
            <PostContentContainer>
              <TitlePost>Primeiro aquário marinho</TitlePost>
              <PostInfoContainer>
                <div>
                  <h2>Criado Por:</h2>
                  <span>Diegoch</span>
                </div>
                <div>
                  <h2>Data:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Tipo de Postagem:</h2>
                  <span>Fórum</span>
                </div>
                <div>
                  <h2>Comentários:</h2>
                  <span>12</span>
                </div>
                <div>
                  <h2>Úiltimo Comentário:</h2>
                  <span>26/06/2024</span>
                </div>
                <div>
                  <h2>Comentado Por:</h2>
                  <span>usuario1989</span>
                </div>
              </PostInfoContainer>
            </PostContentContainer>
          </Item>
        </ListItemContainer>
      </BoxContent>
    </Container>
  );
};

export default Content;
