import styled from 'styled-components';

export const Container = styled.div`
  grid-area: CT;
  background-color: ${(prop) => prop.theme.colors.white};
  color: ${(prop) => prop.theme.colors.white};
  width: 100%;
  height: 100%;
  padding: 5px;
`;

export const BoxContent = styled.div`
  background-color: ${(prop) => prop.theme.colors.lighter};
  width: 100%;
  padding: 20px 20px;
  border-radius: 6px;
  color: ${(props) => props.theme.colors.black};
  margin-bottom: 5px;
`;

export const TitleSession = styled.h1`
  color: ${(props) => props.theme.colors.darker};
  margin-bottom: 10px;
  font-size: 18px;
`;

export const RecentPostContainer = styled.div`
  width: 100%;
  background-color: ${(props) => props.theme.colors.white};
  border-radius: 6px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  border: 1px solid ${(props) => props.theme.colors.darker};
  padding: 10px;
`;

export const BoxRecentPostContent = styled.div`
  display: flex;
  flex-direction: column;
  width: 100%;
`;

export const ImageRecentPostContainer = styled.div`
  min-width: 200px !important;
  height: 200px;
  background-color: #ccc;
  border-radius: 6px;
`;

export const ImageRecentPost = styled.img`
  width: 100%;
  height: 100%;
  border-radius: 6px;
`;

export const ContentRecentePost = styled.div`
  display: flex;
  flex-direction: column;
  align-items: start;
  width: 100%;
  height: 200px;

  padding: 0 10px;
  color: ${(props) => props.theme.colors.darker};

  span {
    font-size: 12px;
  }
`;

export const TitleRecentPost = styled.div`
  display: flex;
  flex-direction: column;
  color: ${(props) => props.theme.colors.darker};
  margin-bottom: 20px;

  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 18px;
  }
`;

export const DateRecentPost = styled.div`
  width: 100%;
  display: flex;
  justify-content: flex-end;
  font-weight: 500;
  gap: 10px;
  color: ${(props) => props.theme.colors.darker};
  font-size: 12px;
`;

export const ListItemContainer = styled.div`
  width: 100%;
  background-color: ${(props) => props.theme.colors.white};
  border-radius: 6px;
  display: flex;
  flex-direction: column;
  border: 1px solid ${(props) => props.theme.colors.darker};
  margin: 10px 0;
  padding: 10px;
`;

export const Item = styled.div`
  width: 100%;
  min-height: 60px;
  border-bottom: 1px solid ${(props) => props.theme.colors.gray};
  display: flex;
  padding: 0 10px;
  align-items: center;
  gap: 20px;
`;

export const UserImageContainer = styled.div`
  background-color: #ccc;
  width: 40px;
  height: 40px;
  border-radius: 50%;
`;

export const UserImage = styled.img`
  width: 100%;
  height: 100%;
  min-height: 40px;
  min-width: 40px;
  border-radius: 50%;
`;

export const PostContentContainer = styled.div`
  display: flex;
  flex-direction: column;
  height: 100%;
  padding: 10px;
`;

export const PostInfoContainer = styled.div`
  display: flex;
  flex-wrap: wrap;
  width: 100%;
  height: 100%;

  div {
    display: flex;
    flex-direction: row;
    margin-right: 10px;
  }

  h2 {
    white-space: nowrap;
    font-size: 13px;
    font-weight: 500;
    margin-right: 3px;
  }

  span {
    font-size: 13px;
  }
`;

export const TitlePost = styled.h1`
  font-size: 16px;
  color: ${(props) => props.theme.colors.dark};
  margin-bottom: 10px;
`;
